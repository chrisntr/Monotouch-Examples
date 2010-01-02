
using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.Drawing;
using MonoTouch.CoreAnimation;
using System.Text.RegularExpressions;
using System.Text;
using MonoTouch.AudioToolbox;
using MonoTouch.ObjCRuntime;
using System.Threading;

namespace MonotouchExamples
{
	public class Application
	{
		static void Main (string[] args)
		{
			UIApplication.Main (args);
		}
	}

	// The name AppDelegate is referenced in the MainWindow.xib file.
	public partial class AppDelegate : UIApplicationDelegate
	{
		int timerCount = 0;
		
		// This method is invoked when the application has loaded its UI and its ready to run
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			#region Logging
			var myString = "MyString";
			var myFloat = 4.56f;
			var myInt = 5;
			
			Console.WriteLine(String.Format("log: {0}", myString));
			Console.WriteLine(String.Format("log: {0}", myFloat));
			Console.WriteLine(String.Format("log: {0}", myInt));
			#endregion            
			
			
			#region Display Images 
			// Make sure your image is included in the project and Build Action is set to 'Content'
			/*
			var imageRect = new RectangleF(0f, 0f, 320f, 109f); 
			using (var myImage = new UIImageView(imageRect))
			{
				myImage.Image = UIImage.FromFile("myImage.png");
				myImage.Opaque = true;
				view.AddSubview(myImage);
			}*/
			#endregion
			
			
			#region Web view
			/*
			var webRect = new RectangleF(0f, 0f, 320f, 460f);
			using (var webView = new UIWebView(webRect))
			{
				webView.BackgroundColor = UIColor.White;
				var urlAddress = "http://www.google.com";
				var url = new NSUrl(urlAddress);
				var urlRequest = new NSUrlRequest(url);
				webView.LoadRequest(urlRequest);
				view.AddSubview(webView);
			}*/
			#endregion
			
			
			#region Display the Network Activity Status Indicator
			/*var app = UIApplication.SharedApplication;
			app.NetworkActivityIndicatorVisible = true; 
			// Set True to display, False to hide.*/
			#endregion
			
			
			#region Animation: Series of images
			/*List<UIImage> myImages = new List<UIImage>();
			myImages.Add(UIImage.FromFile("myImage1.png"));
			myImages.Add(UIImage.FromFile("myImage2.png"));
			myImages.Add(UIImage.FromFile("myImage3.png"));
			myImages.Add(UIImage.FromFile("myImage4.png"));
			
			var myAnimatedView = new UIImageView(view.Bounds);
			myAnimatedView.AnimationImages = myImages.ToArray();
			myAnimatedView.AnimationDuration = 1.75; // Seconds
			myAnimatedView.AnimationRepeatCount = 0; // 0 = Loops Forever
			myAnimatedView.StartAnimating();
			view.AddSubview(myAnimatedView);*/
			#endregion
			
			
			#region Animation: Move an object
			/*
			var theAnimation = CABasicAnimation.FromKeyPath("transform.translation.x");
			theAnimation.Duration = 1;
			theAnimation.From = NSNumber.FromFloat(0f);
			theAnimation.To = NSNumber.FromFloat(-60f);
			exampleLabel.Layer.AddAnimation(theAnimation, "animateLabel");*/
			#endregion
			
			
			#region NSString and int
			/*var currentInt = 5;
			exampleLabel.Text = String.Format("Int = {0}", currentInt); */
			#endregion
			
			
			#region Regular Expressions (RegEx)
			/*var emailRegex = @"^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$";
			var realEmail = "my@email.com";
			var fakeEmail = "notAEmailAddress.com";
			var formatString = "{0} is a real e-mail = {1}";
			Console.WriteLine ((String.Format(formatString, realEmail, Regex.IsMatch(realEmail, emailRegex))));			
			Console.WriteLine ((String.Format(formatString, fakeEmail, Regex.IsMatch(fakeEmail, emailRegex))));*/
			#endregion
			
			
			#region Draggable Items
			/* var image = UIImage.FromFile("myImage.png");
			var draggableRect = new RectangleF(0f, 0f, image.Size.Width, image.Size.Height);
			var dragger = new MyDraggableImage(draggableRect);
			dragger.Image = image;
			dragger.UserInteractionEnabled = true;
			view.AddSubview(dragger);*/
			#endregion
			
			
			#region Vibration and Sound
			// Will Only work on device
			/*SystemSound.Vibrate.PlaySystemSound();
			
			var sound = new SystemSound(new NSUrl("audioFile.caf"));
			sound.PlaySystemSound();*/
			#endregion
		
			
			#region Threads
			/*var thread = new Thread(NewThreadMethod as ThreadStart);
			thread.Start();*/
			#endregion
			
			
			#region Access properties/methods in other classes
			/*var appDelegate = (AppDelegate) UIApplication.SharedApplication.Delegate;
			appDelegate.view.BackgroundColor = UIColor.Green;*/
			#endregion
			
			
			#region Random Numbers
			/*Random r = new Random();
			var randomNumber = r.Next();*/
			#endregion
			
			
			#region Timers
			/*var timer = NSTimer.CreateRepeatingScheduledTimer(TimeSpan.FromSeconds(1), OneSecondTimer);*/
			
			/*var userInfo = new NSString("MyUserInfo");
			var timer = NSTimer.CreateScheduledTimer(1, this, new Selector("OneSecondTimer"), userInfo, true);*/
			#endregion
			
			
			#region Time
			/*var currentTime = DateTime.UtcNow;
			Console.WriteLine ("Date/Time: " + currentTime);*/
			#endregion
			
			
			#region Alert
			/*using(var alert = new UIAlertView("Title", "Message", null, "OK", null))
			{
				alert.Show();	
			}*/
			#endregion
			
			
			#region Plist Files
			/*var plist = NSUserDefaults.StandardUserDefaults;
			var myKey = plist["myKey"];
			// Or
			var myKey2 = plist.StringForKey("myKey2");
			var myBoolKey = plist.BoolForKey("myBoolKey");
			var myIntKey = plist.IntForKey("myIntKey");
			
			plist.SetString("Save this string", "myStringKey");
			// Saves the new "myStringKey" string.
			plist.Synchronize();*/
			#endregion
			
			
			#region Info button
			/*var f = infoButton.Frame;
			var newInfoButtonRectangle = new RectangleF(f.X - 25f, f.Y - 25f, f.Width + 50f, f.Height + 50f);
			infoButton.Frame = newInfoButtonRectangle;*/
			#endregion
			
			
			#region Detecting Subviews
			/*foreach(var view in this.window.Subviews)
			{
				Console.WriteLine ("View" + view.ToString());
				foreach(var subView in this.view.Subviews)
				{
					Console.WriteLine ("SubView: " + subView.ToString());
				}
			}*/
			#endregion
			
			
			window.MakeKeyAndVisible ();
			
			return true;
		}
		
		void OneSecondTimer()
		{
			Console.WriteLine ("One Second Timer fired.");
		}
		
		[Export("OneSecondTimer")]
		void OneSecondTimer(NSTimer timer)
		{
			timerCount++;
			var userInfoString = timer.UserInfo.ToString();
			Console.WriteLine (String.Format("One Second Timer (Number {0}) With Timer Passed In fired with User Info '{1}'", timerCount, userInfoString));	
			
			// Invalidate the timer after 5 calls.
			if(timerCount == 5)
			{
				timer.Invalidate();
				timer = null;
			}
		}
		
		[Export("NewThreadMethod")]
		void NewThreadMethod()
		{
			using(var pool = new NSAutoreleasePool())
			{
				Console.WriteLine ("Run Thread Code...");
				// Run New Thread Code.	
					
				InvokeOnMainThread( delegate {
					// Update UI Code (in Main thread) from the new thread.	
					exampleLabel.Text = "Invoked on Main thread from a new thread";
				});
			}
		}
		
		// This method is required in iPhoneOS 3.0
		public override void OnActivated (UIApplication application)
		{
		}
	}
	
	public class MyDraggableImage : UIImageView
	{
		public MyDraggableImage(RectangleF frame) : base(frame)
		{
		}
		
		public PointF StartLocation { get; set; }
		
		public override void TouchesBegan (NSSet touches, UIEvent evt)
		{
			var pt = (touches.AnyObject as UITouch).LocationInView(this);
			StartLocation = pt;
			this.Superview.BringSubviewToFront(this);
		}
		
		public override void TouchesMoved (NSSet touches, UIEvent evt)
		{
			// Move relative to the original touch point 
			var pt = (touches.AnyObject as UITouch).LocationInView(this);
			var frame = this.Frame;
			frame.X += pt.X - StartLocation.X;
			frame.Y += pt.Y - StartLocation.Y;
			this.Frame = frame;
		}
		
		public override void TouchesEnded (NSSet touches, UIEvent evt)
		{
			// Move relative to the original touch point 
			var pt = (touches.AnyObject as UITouch).LocationInView(this);
			var frame = this.Frame;
			frame.X += pt.X - StartLocation.X;
			frame.Y += pt.Y - StartLocation.Y;
			this.Frame = frame;
		}


	}
}
