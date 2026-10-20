# Introdução ao Windows Forms — Lista de Tarefas

Projeto de exemplo para ensinar a estrutura básica de uma aplicação Windows Forms em C#.

## Como abrir e rodar

1. Dê duplo clique em `IntroWinForms.sln` para abrir a solução no Visual Studio
   (requer Visual Studio com suporte a .NET 10, ou o SDK do .NET 10 instalado).
2. Ou, via terminal, na pasta que contém o `.sln`, rode `dotnet run --project IntroWinForms`
   (requer .NET 10 SDK e Windows).
3. O Visual Studio vai reconhecer `Form1.cs` como um formulário visual: clique duas
   vezes nele no Solution Explorer para abrir o Designer (arrastar-e-soltar).

## Estrutura de arquivos (o padrão de todo projeto WinForms)

| Arquivo | O que é | O que geralmente faz nele |
|---|---|---|
| `Program.cs` | Ponto de entrada da aplicação | Raramente é editado |
| `Form1.Designer.cs` | Layout visual (posição, tamanho, propriedades dos controles) | Editado pelo Visual Studio quando você mexe no Designer visual — evite editar manualmente |
| `Form1.cs` | Code-behind: lógica, eventos, regras de negócio | É aqui que você escreve a maior parte do código |
| `IntroWinForms.csproj` | Configuração do projeto (framework, dependências) | Editado raramente |

`Form1.Designer.cs` e `Form1.cs` são a **mesma classe** (`partial class Form1`) dividida
em dois arquivos — separação por convenção: um cuida da aparência, o outro do
comportamento.

## Conceitos demonstrados no exemplo

- Controles: `Label`, `TextBox`, `Button`, `ListBox`, `CheckBox`, `StatusStrip`
- Eventos: `Click`, `KeyDown`, `SelectedIndexChanged`, `CheckedChanged`
- Separação entre **dados** (lista `List<Tarefa>`) e **exibição** (`ListBox`)
- Validação simples de entrada do usuário
- `MessageBox` para feedback ao usuário

## Sugestões de exercícios para os alunos

1. Adicionar um botão "Editar" que carrega a tarefa selecionada de volta no `TextBox`.
2. Persistir a lista de tarefas em um arquivo de texto ou JSON ao fechar o formulário.
3. Adicionar uma `ComboBox` de prioridade (Baixa/Média/Alta) e colorir o item na lista.
4. Trocar o `MessageBox` de aviso por uma cor de fundo temporária no `TextBox`.
