# Projeto Oficina (VB.NET)

Sistema desktop para gestão de oficina mecânica, desenvolvido em **VB.NET (Windows Forms)**.

## Visão geral

O repositório contém uma solução Visual Studio (`prjads_va2.sln`) com telas para:

- autenticação (`Menu_login`)
- menu principal com submenus (`MenuGeral`)
- cadastro de clientes (`Cadastrar_Clientes`)
- cadastro de veículos (`Cadastrar_veiculos`)
- checklist (`Checklist`)

Também existe um script SQL com a modelagem principal do banco em `SolucaoProjeto.sql`.

## Estrutura do repositório

- `projeto_oficina_VB.NET/prjads_va2.sln` — solução Visual Studio
- `projeto_oficina_VB.NET/prjads_va2.vbproj` — projeto WinForms (.NET Framework 4.7.2)
- `projeto_oficina_VB.NET/*.vb` — código-fonte das telas e módulo principal
- `projeto_oficina_VB.NET/SolucaoProjeto.sql` — criação das tabelas da oficina
- `projeto_oficina_VB.NET/packages.config` — dependências NuGet

## Tecnologias e dependências

- **VB.NET / Windows Forms**
- **.NET Framework 4.7.2**
- **MySQL** (via `MySql.Data`)
- Bibliotecas de UI: **Bunifu** e **Guna.UI** (referências locais no `.vbproj`)
- `Twilio` (importado no módulo principal)

## Banco de dados

O script `SolucaoProjeto.sql` cria as tabelas:

- `tb_clientes`
- `tb_veiculos`
- `tb_orcamentos`
- `tb_pecas_servicos`
- `tb_checklist`
- `tb_agendamentos`

No código (`Module1.vb`) há conexão de exemplo para o banco `OFICINA` em `localhost`.

## Como abrir e executar

1. Abra `projeto_oficina_VB.NET/prjads_va2.sln` no Visual Studio (Windows).
2. Garanta o **.NET Framework 4.7.2 Developer Pack** instalado.
3. Configure o MySQL local e execute o script `SolucaoProjeto.sql`.
4. Ajuste a string de conexão conforme seu ambiente.
5. Compile e execute o projeto.

## Observações importantes

- O projeto é **WinForms .NET Framework** e depende de ambiente Windows para execução completa.
- Algumas referências de UI no `.vbproj` apontam para caminhos locais (`C:\Users\Aluno\...`) e podem precisar ser reconfiguradas.
- Não foi encontrado `README.md` prévio na raiz; este arquivo foi criado com base no conteúdo atual do repositório.
