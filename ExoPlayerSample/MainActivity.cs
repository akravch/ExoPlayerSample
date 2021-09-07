using Android.App;
using Android.OS;
using AndroidX.AppCompat.App;
using Com.Google.Android.Exoplayer2.Source.Hls.Playlist;

namespace ExoPlayerSample
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            var _ = typeof(HlsMasterPlaylist);
        }
	}
}
