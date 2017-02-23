using ReactNative.Bridge;
using System;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace gwsconnect
{
    class GoogleAnalyticsClass : ReactContextNativeModuleBase, ILifecycleEventListener
    {

        public GoogleAnalyticsClass(ReactContext reactContext)
            : base(reactContext)
        {

        }

        public override string Name
        {
            get
            {
                return "GoogleAnalyticsClass";
            }
        }

        [ReactMethod]
        public async void trackScreen(string screen)
        {
            try
            {
                RunOnDispatcher(() =>
                {
                    GoogleAnalytics.EasyTracker.GetTracker().SendView(screen);
                });
            }
            catch (Exception ex)
            {

            }
            
        }

        private static async void RunOnDispatcher(DispatchedHandler action)
        {
            await CoreApplication.MainView.CoreWindow.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, action).AsTask().ConfigureAwait(false);
        }


        [ReactMethod]
        public void trackEvent(string category, string eventString)
        {
            try
            {
                RunOnDispatcher(() =>
                {
                    GoogleAnalytics.EasyTracker.GetTracker().SendEvent(category, eventString, null, 0);
                });
            }
            catch (Exception ex)
            {

            }
           
        }

        public void OnDestroy()
        {
            throw new NotImplementedException();
        }

        public void OnResume()
        {
            throw new NotImplementedException();
        }

        public void OnSuspend()
        {
            throw new NotImplementedException();
        }
    }
}
