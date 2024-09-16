<h1 align="center">CVV App - Centro de Valorização da Vida</h1>

<p>Bem-vindo ao CVV App! Este é um aplicativo mobile desenvolvido com .NET MAUI e C#, criado para facilitar o acesso aos serviços de apoio emocional fornecidos pelo Centro de Valorização da Vida (CVV). O CVV oferece apoio emocional gratuito e sigiloso, disponível 24 horas por dia, por telefone, chat e e-mail, com o objetivo de prevenir o suicídio e promover a saúde mental. Desenvolvido como trabalho final do curso de Desenvolvimento Web (TDS) no Instituto Federal de Brasília - Campus Brasília, com a tutoria da professora Kadidja Oliveira.</p>

<section>
            <h1 align="center">📃 Documentação</h1>
            <p align="center">
                <a href="https://drive.google.com/file/d/1DtWBoFHUyJboX08aTTFflzYkCoM8q4x6/view?usp=sharing">Clique aqui para ler a documentação completa do CVV App</a>
            </p>
        </section>

<h1 align="center">⬇ Demonstração</h1>

<p align="center">
  <img src="https://github.com/user-attachments/assets/b6e6c91f-4fb6-4bcb-b7d7-26b186e7ef6b" alt="Demonstração do CVV App" />
</p>

<h2 align="center">📱 Abaixo você pode ver uma demonstração de como o aplicativo funciona:</h2>
<p align="center">
  <a href="https://www.figma.com/proto/FbJ7ZX04wGpkE9wnl2xjoA/CVV-APP?node-id=20-28&node-type=canvas&t=2csSPgefAZgBADcE-0&scaling=scale-down&content-scaling=fixed&page-id=20%3A27">Clique aqui para visualizar o protótipo no Figma</a>
</p>

<h2 align="center">📲 Veja o Aplicativo funcionando: </h2>
<p align="center">
  <a href="https://drive.google.com/file/d/1t9rklULcccuuS-tolU1Mk9PMuX5ZZFHw/view?usp=sharing">Clique aqui para visualizar o Vídeo do Aplicativo</a>
</p>

<h2 align="left">⚪ Objetivo do Projeto</h2>
<p>Com o aumento da necessidade de suporte emocional, muitas pessoas enfrentam dificuldades em acessar os serviços do CVV rapidamente. O CVV App tem como objetivo simplificar esse processo, permitindo que os usuários façam chamadas de voz, acessem o chat online e obtenham informações sobre o CVV diretamente do seu smartphone.</p>

<h2 align="left">⚪ Funcionalidades</h2>
<p>O CVV App integra os serviços do CVV em um único aplicativo, oferecendo as seguintes funcionalidades:</p>

<ul>
  <li><b>Chamadas de Voz</b>: Ligação direta para o número 188, a linha oficial de apoio emocional do CVV.</li>
</ul>


            private void ChaBtn_Clicked(object sender, EventArgs e) {
                try {
                    if (PhoneDialer.Default.IsSupported) {
                        PhoneDialer.Default.Open("188");
                    }
                } catch (Exception ex) {
                    Console.WriteLine($"Erro ao Fazer Chamada: {ex.Message}");
                }
            }

<ul>
<li><b>Chat Online</b>: Botão que redireciona o usuário ao chat seguro do CVV.</li>
</ul>

            private async void ChatBtn_Clicked(object sender, EventArgs e) {
                var chatUrl = "https://servidorseguro.mysuite1.com.br/empresas/cvw/verificaseguro.php";
                try {
                    await Launcher.OpenAsync(new Uri(chatUrl));
                } catch (Exception ex) {
                    Console.WriteLine($"Erro ao abrir o chat: {ex.Message}");
                }
            }

<ul> <li><b>Acesso às Redes Sociais</b>: Conexões diretas com as redes sociais do CVV, como Facebook e Instagram.</li> </ul>

            private async void FaceBtn_Clicked(object sender, EventArgs e) {
                var face = new Uri("https://www.facebook.com/cvvoficial/");
                await Launcher.OpenAsync(face);
            }
            
            private async void InstaBtn_Clicked(object sender, EventArgs e) {
                var inst = new Uri("https://www.instagram.com/cvvoficial/");
                await Launcher.OpenAsync(inst);
            }

<ul> <li><b>Informações sobre o CVV</b>: Acesso direto ao site oficial do CVV.</li> </ul>

            private async void DuvidaBtn_Clicked(object sender, EventArgs e) {
                var duv = new Uri("https://cvv.org.br/");
                await Launcher.OpenAsync(duv);
            }

<h2 align="left">⚪ Interface de Usuário</h2> <p>A interface foi projetada usando XAML, com um layout simples e intuitivo, onde os botões de ação são organizados verticalmente, proporcionando uma navegação fácil e rápida. O design é responsivo, adaptando-se a diferentes tamanhos de tela.</p> <h2 align="left">⚪ Ferramentas Utilizadas</h2> <ul> <li>.NET MAUI: Framework utilizado para criar o aplicativo nativo.</li> <li>C#: Linguagem principal para a lógica do aplicativo.</li> <li>Visual Studio Community: IDE para o desenvolvimento.</li> <li>Figma: Ferramenta de prototipagem para o design do app.</li> <li>GitHub: Controle de versão e colaboração.</li> </ul> <h2 align="left">⚪ Como Executar o Projeto</h2> <ol> <li>Clone o repositório: <pre><code>git clone https://github.com/seu-usuario/cvv-app.git</code></pre> </li> <li>Abra o projeto no Visual Studio.</li> <li>Instale as dependências necessárias do .NET MAUI.</li> <li>Execute o aplicativo em um emulador ou dispositivo físico.</li> </ol> <h2 align="left">⚪ Contribuições</h2> <p>Quer contribuir para o projeto? Sinta-se à vontade para fazer um fork, criar uma nova branch, e submeter um pull request. Todas as contribuições são bem-vindas!</p> <h1 align="center">📩 Contato</h1> <p align="left">Para mais informações, entre em contato com os desenvolvedores:</p> <ul> <li>Douglas Souza Silva - <a href="mailto:ddouglss1999@gmail.com">ddouglss1999@gmail.com</a></li> <li>Guilherme Guimarães - <a href="mailto:guiguimaraes906@gmail.com">guiguimaraes906@gmail.com</a></li> <li>Wallison Andrade - <a href="mailto:wallisonandrade131@gmail.com">wallisonandrade131@gmail.com</a></li> <li>Victor Augusto - <a href="mailto:victorp3augusto@gmail.com">victorp3augusto@gmail.com</a></li> </ul> <p>Muito obrigado!</p> ```









