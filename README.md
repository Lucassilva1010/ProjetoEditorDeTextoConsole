# Projeto Editor de Texto em C#

Este é um projeto de editor de texto simples desenvolvido em C# que oferece funcionalidades básicas para criar, abrir, editar e salvar arquivos de texto. O projeto utiliza várias estruturas de controle, como `switch`, `while`, `do while`, e faz uso das classes `StreamReader` e `StreamWriter` para lidar com operações de leitura e escrita de arquivos de texto. Além disso, é implementado um mecanismo de pausa usando `Thread.Sleep` para melhorar a experiência do usuário.

## Funcionalidades

- **Menu Interativo**: O projeto utiliza um menu interativo com um loop `while` e uma estrutura `switch` para permitir ao usuário escolher entre operações como criar um novo arquivo, abrir um arquivo existente, editar o conteúdo e salvar as alterações.

- **Abrir Arquivos**: A funcionalidade de abrir arquivos é implementada com um loop `do while`, e utiliza `StreamReader` com a instrução `using` para abrir e ler o conteúdo de um arquivo de texto existente. O `StreamReader` recebe como parâmetro o caminho do arquivo a ser aberto, que é fornecido pelo usuário.

- **Criar/Editar Conteúdo**: A edição do conteúdo do arquivo é implementada com outro loop `do while` para criar/editar o texto. O usuário pode sair do loop pressionando a tecla "Esc". O comando `Environment.NewLine` é usado para inserir uma quebra de linha ao criar/editar o conteúdo, garantindo a formatação adequada.

- **Salvar Arquivos**: Para salvar o conteúdo editado, o projeto utiliza um loop `do while`, e `StreamWriter` com a instrução `using` para salvar as alterações em um arquivo de texto existente. O parâmetro `path` é usado para especificar o caminho do arquivo a ser salvo. O comando `StreamWriter(path)` é responsável por criar um novo arquivo no caminho especificado ou substituir um arquivo existente pelo conteúdo atualizado.

- **Pausa Personalizada**: O projeto inclui `Thread.Sleep(1000);` para criar um atraso de 1 segundo entre as operações. Isso melhora a experiência do usuário, permitindo uma pausa antes de continuar com a próxima ação.

- **Finalização da Aplicação**: O comando `System.Environment.Exit(0)` é usado para encerrar a aplicação. Isso permite que o usuário saia da aplicação de forma controlada.

## Como Usar

Para usar o projeto do editor de texto, siga estas etapas:

1. Clone o repositório para sua máquina local:

   ```bash
   git clone https://github.com/Lucassilva1010/ProjetoEditorDeTextoConsole.git
   
