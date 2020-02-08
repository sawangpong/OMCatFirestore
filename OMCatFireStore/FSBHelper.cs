using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Cloud.Storage;
using Google.Cloud.Storage.V1;
using System.IO;
using System.Runtime.InteropServices;

namespace OMCatFireStore
{
	public enum ActionMode
	{
		None,
		Add,
		Edit
	}


	//public static FirestoreDb CreateFirestoreDbWithEmailAuthentication(string emailAddress, string password, string firebaseApiKey, string firebaseProjectId)
	//{
	//    // Create a custom authentication mechanism for Email/Password authentication
	//    // If the authentication is successful, we will get back the current authentication token and the refresh token
	//    // The authentication expires every hour, so we need to use the obtained refresh token to obtain a new authentication token as the previous one expires
	//    var authProvider = new FirebaseAuthProvider(new FirebaseConfig(firebaseApiKey));
	//    var auth = authProvider.SignInWithEmailAndPasswordAsync(emailAddress, password).Result;
	//    var callCredentials = CallCredentials.FromInterceptor(async (context, metadata) =>
	//    {
	//        if (auth.IsExpired()) auth = await auth.GetFreshAuthAsync();
	//        if (string.IsNullOrEmpty(auth.FirebaseToken)) return;

	//        metadata.Clear();
	//        metadata.Add("authorization", $"Bearer {auth.FirebaseToken}");
	//    });
	//    var credentials = ChannelCredentials.Create(new SslCredentials(), callCredentials);

	//    // Create a custom Firestore Client using custom credentials
	//    var grpcChannel = new Channel("firestore.googleapis.com", credentials);
	//    var grcpClient = new Firestore.FirestoreClient(grpcChannel);
	//    var firestoreClient = new FirestoreClientImpl(grcpClient, FirestoreSettings.GetDefault());

	//    return FirestoreDb.Create(firebaseProjectId, null, firestoreClient);
	//}
	public static class FSBHelper
	{

		public static string service_account_key = "3da75055f196004edcd6cccc98f8e2bd006a48d2";

		// Create Firebase connection to FireStore Database
		// Project id = 'OMCat20'
		public static string projectId = "omcat20";
		public static string projectName = "OMCat20";
		public static FirestoreDb db = FirestoreDb.Create("omcat20");
		public static string wedAPIKey = "AIzaSyArIv-Ffc6wPWFXgtBYHhbBupVSmS_Iww4";

		public static string AndroidAppName = "OldmoonCatalog2020";
		public static string AppAndroidId = "1:1054757463439:android:048039ad2daeb1070417fa"; // for Android Flutter

		public static string WebAppName = "OMCat20Desktop";
		public static string AppDestopId = "1:1054757463439:web:6ddb666f1db1f7c40417fa"; // for Desktop/Web Flutter

		public static string StorageBucketName = "omcat20.appspot.com";
		public static string FolderPath = "gs://omcat20.appspot.com";

		/*
		 * Configuration
		 * const firebaseConfig = {
		  apiKey: "AIzaSyArIv-Ffc6wPWFXgtBYHhbBupVSmS_Iww4",
		  authDomain: "omcat20.firebaseapp.com",
		  databaseURL: "https://omcat20.firebaseio.com",
		  projectId: "omcat20",
		  storageBucket: "omcat20.appspot.com",
		  messagingSenderId: "1054757463439",
		  appId: "1:1054757463439:web:6ddb666f1db1f7c40417fa"
		};
		 */

		#region For Image 

		const Int32 WS_EX_LAYERED = 0x80000;
		const Int32 HTCAPTION = 0x02;
		const Int32 WM_NCHIITEST = 0x84;
		const Int32 ULW_ALPHA = 0x02;
		const byte AC_SRC_OVER = 0x00;
		const byte AC_SRC_ALPTH = 0x01;

		[StructLayout(LayoutKind.Sequential)]
		struct Point
		{
			public Int32 x;
			public Int32 y;
			public Point(Int32 x, Int32 y)
			{
				this.x = x;
				this.y = y;
			}
		}

		[StructLayout(LayoutKind.Sequential)]
		struct Size
		{
			public Int32 cx;
			public Int32 cy;
			public Size(Int32 cx, Int32 cy)
			{
				this.cx = cx;
				this.cy = cy;
			}
		}

		[StructLayout(LayoutKind.Sequential, Pack =1)]
		struct ARGB
		{
			public byte Blue;
			public byte Green;
			public byte Red;
			public byte Alpha;
		}

		[StructLayout(LayoutKind.Sequential, Pack =1)]
		struct BLENDFUNCTION
		{
			public byte BlendOp;
			public byte BlendFlags;
			public byte SourceConstantAlpha;
			public byte AlphaFormat;
		}

		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		static extern bool UpdateLayeredWindow(IntPtr hwd, IntPtr hdcDst, ref Point pptDst, ref Size psize, IntPtr hdcSrc, ref Point pprSrc, Int32 crKey, ref BLENDFUNCTION pblend, Int32 deFlags);

		[DllImport("gdi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		static extern IntPtr CreateCompatibleDC(IntPtr hDC);

		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		static extern IntPtr GetDC(IntPtr hWnd);

		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		static extern IntPtr ReleaseDC(IntPtr hWnd, IntPtr hDC);

		[DllImport("gdi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		static extern bool DeleteDC(IntPtr hdc);

		[DllImport("gdi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		static extern IntPtr SelectObject(IntPtr hDC, IntPtr hObject);

		[DllImport("gdi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		static extern bool DeleteObject(IntPtr hObject);

		//public static void SelectBitmap(Bitmap bitmap, int opacity)
		//{
		//	// Does this bitmap contain an alpha channel?
		//	if(bitmap.PixelFormat != PixelFormat.Format32bppArgb)
		//	{
		//		throw new ApplicationException("The bitmap must be 32bpp with alpha-channel.");
		//	}

		//	// Get device contexts
		//	IntPtr screenDC = GetDC(IntPtr.Zero);
		//	IntPtr memDc = CreateCompatibleDC(screenDC);
		//	IntPtr hBitmap = IntPtr.Zero;
		//	IntPtr hOldBitmap = IntPtr.Zero;

		//	try
		//	{
		//		hBitmap = bitmap.GetHbitmap(Color.FromArgb(0));
		//		hOldBitmap = SelectObject(memDc, hBitmap);

		//		Size newSize = new Size(bitmap.Width, bitmap.Height);
		//		Point sourceLocation = new Point(0, 0);
		//		Point newLocation = new Point(this.Left, this.Top);
		//		BLENDFUNCTION blend = new BLENDFUNCTION();
		//		blend.BlendOp = AC_SRC_OVER;
		//		blend.BlendFlags = 0;
		//		blend.SourceConstantAlpha = (byte)opacity;
		//		blend.AlphaFormat = AC_SRC_ALPHA;

		//		// Update the window.
		//		UpdateLayeredWindow(
		//			this.Handle,     // Handle to the layered window
		//			screenDc,        // Handle to the screen DC
		//			ref newLocation, // New screen position of the layered window
		//			ref newSize,     // New size of the layered window
		//			memDc,           // Handle to the layered window surface DC
		//			ref sourceLocation, // Location of the layer in the DC
		//			0,               // Color key of the layered window
		//			ref blend,       // Transparency of the layered window
		//			ULW_ALPHA        // Use blend as the blend function
		//			);
		//	}
		//	finally
		//	{
		//		// release device context.
		//		ReleaseDC(IntPtr.Zero, screenDC);
		//		if(hBitmap != IntPtr.Zero)
		//		{
		//			SelectObject(memDc, hOldBitmap);
		//			DeleteObject(hBitmap);
		//		}
		//		DeleteObject(memDc);
		//	}
		//}

		public static string ConvertImageToBase64(Image image)
		{
			string resultStringImage = "";
			using (MemoryStream ms = new MemoryStream())
			{
				image.Save(ms, ImageFormat.Jpeg);
				byte[] a = ms.GetBuffer();
				resultStringImage = Convert.ToBase64String(a);
			}

			return resultStringImage;
		}

		public static Image ConvertBase64ToImage(string imageString)
		{
			Image resultImage;

			byte[] b = Convert.FromBase64String(imageString);
			using (MemoryStream ms = new MemoryStream())
			{
				ms.Write(b, 0, Convert.ToInt32(b.Length));
				resultImage = Bitmap.FromStream(ms, true,true );
			}

			return resultImage;
		}


		#endregion


	}
}
