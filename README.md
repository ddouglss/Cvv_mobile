    CVV App - Centro de Valorização da Vida

Bem-vindo ao CVV App! Este é um aplicativo mobile desenvolvido com .NET MAUI e C#, criado para facilitar o acesso aos serviços de apoio emocional fornecidos pelo Centro de Valorização da Vida (CVV). O CVV oferece apoio emocional gratuito e sigiloso, disponível 24 horas por dia, por telefone, chat e e-mail, com o objetivo de prevenir o suicídio e promover a saúde mental.

Demonstração

Abaixo você pode ver uma demonstração de como o aplicativo funciona:

[![image](https://github.com/user-attachments/assets/b6e6c91f-4fb6-4bcb-b7d7-26b186e7ef6b)
]

     link:https://www.figma.com/proto/FbJ7ZX04wGpkE9wnl2xjoA/CVV-APP?node-id=20-28&node-type=canvas&t=2csSPgefAZgBADcE-0&scaling=scale-down&content-scaling=fixed&page-id=20%3A27


Objetivo do Projeto

Com o aumento da necessidade de suporte emocional, muitas pessoas enfrentam dificuldades em acessar os serviços do CVV rapidamente. O CVV App tem como objetivo simplificar esse processo, permitindo que os usuários façam chamadas de voz, acessem o chat online e obtenham informações sobre o CVV diretamente do seu smartphone.

Funcionalidades

O CVV App integra os serviços do CVV em um único aplicativo, oferecendo as seguintes funcionalidades:

Chamadas de Voz: Ligação direta para o número 188, a linha oficial de apoio emocional do CVV.

            private void ChaBtn_Clicked(object sender, EventArgs e) {
    try {
        if (PhoneDialer.Default.IsSupported) {
            PhoneDialer.Default.Open("188");
        }
    } catch (Exception ex) {
        Console.WriteLine($"Erro ao Fazer Chamada: {ex.Message}");
    }
    }

Chat Online: Botão que redireciona o usuário ao chat seguro do CVV.

    private async void ChatBtn_Clicked(object sender, EventArgs e) 
    {
    var chatUrl = "https://servidorseguro.mysuite1.com.br/empresas/cvw/verificaseguro.php";
    try {
        await Launcher.OpenAsync(new Uri(chatUrl));
    } catch (Exception ex) {
        Console.WriteLine($"Erro ao abrir o chat: {ex.Message}");
    }

Acesso às Redes Sociais: Conexões diretas com as redes sociais do CVV, como Facebook e Instagram.


    private async void FaceBtn_Clicked(object sender, EventArgs e)
    {
    var face = new Uri("https://www.facebook.com/cvvoficial/");
    await Launcher.OpenAsync(face);
     }

    private async void InstaBtn_Clicked(object sender, EventArgs e)
    {
    var inst = new Uri("https://www.instagram.com/cvvoficial/");
    await Launcher.OpenAsync(inst);
    }

Informações sobre o CVV: Acesso direto ao site oficial do CVV.

    private async void DuvidaBtn_Clicked(object sender, EventArgs e)
    {
    var duv = new Uri("https://cvv.org.br/");
    await Launcher.OpenAsync(duv);
    }

Interface de Usuário
A interface foi projetada usando XAML, com um layout simples e intuitivo, onde os botões de ação são organizados verticalmente, proporcionando uma navegação fácil e rápida. O design é responsivo, adaptando-se a diferentes tamanhos de tela.

Ferramentas Utilizadas
.NET MAUI: Framework utilizado para criar o aplicativo nativo.
C#: Linguagem principal para a lógica do aplicativo.
Visual Studio Community: IDE para o desenvolvimento.
Figma: Ferramenta de prototipagem para o design do app.
GitHub: Controle de versão e colaboração.
Como Executar o Projeto

1-Clone o repositório:

    git clone https://github.com/seu-usuario/cvv-app.git

1-Abra o projeto no Visual Studio.
2-Instale as dependências necessárias do .NET MAUI.
3-Execute o aplicativo em um emulador ou dispositivo físico.

Contribuições
Quer contribuir para o projeto? Sinta-se à vontade para fazer um fork, criar uma nova branch, e submeter um pull request. Todas as contribuições são bem-vindas!

