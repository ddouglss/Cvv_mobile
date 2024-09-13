namespace CvvApp {
    public partial class MainPage : ContentPage {
        int count = 0;

        public MainPage() {
            InitializeComponent();
        }


        private async void FaceBtn_Clicked(object sender, EventArgs e) 
        {
            var face = new Uri ("https://www.facebook.com/cvvoficial/");
            await Launcher.OpenAsync(face);
        }

        private void ChaBtn_Clicked(object sender, EventArgs e) 
        {
            try 
            {
                if (PhoneDialer.Default.IsSupported) 
                {
                    PhoneDialer.Default.Open("188");
                }
            }
            catch ( Exception ex)
            {
                Console.WriteLine($"Erro ao Fazer Chamda: {ex.Message}");
            }

        }

        private async void ChatBtn_Clicked(object sender, EventArgs e) 
        {
            
            var chatUrl = "https://servidorseguro.mysuite1.com.br/empresas/cvw/verificaseguro.php";

            try {
                await Launcher.OpenAsync(new Uri(chatUrl));
            }

            catch (Exception ex) {
                Console.WriteLine($"Erro ao abrir o chat: {ex.Message}");
            }

        }

        private async void InstaBtn_Clicked(object sender, EventArgs e) 
        {
            var inst = new Uri("https://www.instagram.com/cvvoficial/");
            await Launcher.OpenAsync (inst);
        }

        private async void YoutubeBtn_Clicked(object sender, EventArgs e) 
        {
            var yout = new Uri("https://www.youtube.com/user/CVVdivulgacao");
            await Launcher.OpenAsync(yout);
        }

        private async void TikBtn_Clicked(object sender, EventArgs e) 
        {
            var tik = new Uri("https://www.tiktok.com/@cvvoficial");
            await Launcher.OpenAsync(tik);
        }

        private async void DuvidaBtn_Clicked(object sender, EventArgs e) 
        {
            var duv = new Uri("https://cvv.org.br/");
            await Launcher.OpenAsync(duv);
        }
    }

}
