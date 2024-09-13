CVV App - Centro de Valorização da Vida
O CVV App é um aplicativo mobile desenvolvido com .NET MAUI e C# para facilitar o acesso aos serviços de apoio emocional fornecidos pelo Centro de Valorização da Vida (CVV). O CVV oferece ajuda emocional gratuita e sigilosa por telefone, chat e e-mail, 24 horas por dia, com o objetivo de prevenir o suicídio e promover a saúde mental.

Objetivo do Projeto
Com a crescente demanda por suporte psicológico, muitas pessoas enfrentam dificuldades para acessar os serviços do CVV rapidamente. Este aplicativo visa simplificar esse processo, permitindo que os usuários façam chamadas de voz, acessem chats, e recebam informações sobre o CVV diretamente pelo smartphone. A tecnologia oferece um canal eficiente e acessível para aqueles que buscam apoio emocional.

Funcionalidades
O CVV App oferece diversas funcionalidades que integram com os serviços já existentes do CVV, como:

Chamadas de Voz: O usuário pode fazer uma ligação direta para o número 188, a linha oficial de apoio do CVV.

private void ChaBtn_Clicked(object sender, EventArgs e) {
    try {
        if (PhoneDialer.Default.IsSupported) {
            PhoneDialer.Default.Open("188");
        }
    } catch (Exception ex) {
        Console.WriteLine($"Erro ao Fazer Chamada: {ex.Message}");
    }
}

Chat Online: Um botão que direciona o usuário ao chat seguro do CVV, disponível em um servidor externo.

private async void ChatBtn_Clicked(object sender, EventArgs e) {
    var chatUrl = "https://servidorseguro.mysuite1.com.br/empresas/cvw/verificaseguro.php";
    try {
        await Launcher.OpenAsync(new Uri(chatUrl));
    } catch (Exception ex) {
        Console.WriteLine($"Erro ao abrir o chat: {ex.Message}");
    }
}
Acesso às Redes Sociais: Conexões diretas para as redes sociais do CVV, como Facebook, Instagram, YouTube, e TikTok.

private async void FaceBtn_Clicked(object sender, EventArgs e) {
    var face = new Uri("https://www.facebook.com/cvvoficial/");
    await Launcher.OpenAsync(face);
}

private async void InstaBtn_Clicked(object sender, EventArgs e) {
    var inst = new Uri("https://www.instagram.com/cvvoficial/");
    await Launcher.OpenAsync(inst);
}
Informações sobre o CVV: Um botão dedicado que leva os usuários ao site oficial do CVV para mais informações.

private async void DuvidaBtn_Clicked(object sender, EventArgs e) {
    var duv = new Uri("https://cvv.org.br/");
    await Launcher.OpenAsync(duv);
}
Como o Aplicativo Funciona
O CVV App foi construído para ser intuitivo e fácil de usar, com uma interface gráfica simples e acessível. Ao iniciar o aplicativo, o usuário é apresentado a um menu com as principais opções de suporte emocional: chamada de voz, chat e links para redes sociais. O layout é organizado de forma que cada botão seja facilmente acessível, e o aplicativo se adapta a diferentes resoluções de tela.

Interface de Usuário
O layout foi criado usando XAML e organizado em um StackLayout, onde os botões de ação e ícones são dispostos verticalmente, proporcionando uma navegação simples.

<StackLayout>
    <ImageButton x:Name="DuvidaBtn" Clicked="DuvidaBtn_Clicked" Source="questoes.png" WidthRequest="50" HeightRequest="50" HorizontalOptions="EndAndExpand" Margin="0,20,0,45"/>
    <Image Margin="40,0,40,30" Source="logo.png" WidthRequest="355" HeightRequest="238" Aspect="AspectFit" />
    <Button x:Name="ChaBtn" Text="CHAMADA DE VOZ" Clicked="ChaBtn_Clicked" BackgroundColor="#00BBF4" WidthRequest="310" HeightRequest="75" CornerRadius="50" />
    <Button x:Name="ChatBtn" Text="CHAT" Clicked="ChatBtn_Clicked" BackgroundColor="#00BBF4" WidthRequest="310" HeightRequest="75" CornerRadius="50" Margin="10" />
    <HorizontalStackLayout>
        <ImageButton x:Name="FaceBtn" Clicked="FaceBtn_Clicked" Source="face.png" WidthRequest="70" HeightRequest="70" />
        <ImageButton x:Name="InstaBtn" Clicked="InstaBtn_Clicked" Source="instagram.png" WidthRequest="70" HeightRequest="70" />
    </HorizontalStackLayout>
</StackLayout>
Ferramentas Utilizadas
.NET MAUI: Framework utilizado para criar aplicativos nativos para dispositivos móveis.
C#: Linguagem principal para o desenvolvimento da lógica do aplicativo.
Visual Studio Community: Ambiente de desenvolvimento integrado (IDE) para desenvolvimento em plataformas móveis.
Figma: Ferramenta usada para prototipagem da interface do aplicativo.
GitHub: Para controle de versão e colaboração.
Como Executar o Projeto
Clone o repositório:

git clone https://github.com/seu-usuario/cvv-app.git
Abra o projeto no Visual Studio.

Instale as dependências necessárias do .NET MAUI.

Execute o aplicativo em um emulador ou dispositivo físico.

Contribuições
Se você deseja contribuir para este projeto, sinta-se à vontade para fazer um fork do repositório, criar uma nova branch, e submeter um pull request. Sua contribuição será muito bem-vinda!
