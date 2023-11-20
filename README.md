# Savio's Vendas

A aplicação Savio's Vendas, desenvolvida em Linguagem C# no .NET Framework 4.7.2, adota o padrão FluentAPI com camadas bem definidas e desacopladas, permitindo uma manutenção mais simples e a implementação de novos recursos de maneira organizada e eficiente. Além disso, utilizou-se o SQLServer com EntityFramework para lidar com o banco de dados relacional. 

## Organização
A seguir, têm-se a organização do projeto:

- Vendas
    - Vendas.Communication
    - Vendas.DTO
    - Vendas.Entity
    - Vendas.Infrastructure
    - Vendas.Library
    - Vendas.Management
    - Vendas.Repository
    - Vendas.Service
    - Vendas.View

### Communication
Projeto responsável por realizar a comunicação para a camada dos Controladores. Além de classes de envio de email e comunicação do o leitor biométrico.
### DTO
Proojeto responsáveis por implementar as classes DTOs do sistema, as quais auxiliam no preenchimento dos dados nas grids do sistema.
### Entity
Projeto responsável por implementar todas as entidades do sistema de vendas. As principais são: Usuários, produtos e pedidos.
### Infrastructure
Projeto responsável pela configuração do Entity FrameWork, migrações e mapeamento das tabelas no banco de dados.
### Library
Projeto que contém classes auxiliares e estáticas. 
### Management
Projeto responsável por manupular as janelas na aplicação.
### Repository
Projeto responsável por implementar todos os repositórios do sistema, que implementam um interface genérica para lidar com o banco.
### Service
Projeto responsável por implementar todos os controladores e suas respectivas interfaces.
### View
Responsável por implementar todas as telas do sistema de vendas.

## Objetivo
Seu propósito principal é gerenciar de forma eficiente usuários, produtos e pedidos. A tarefa é facilitada com a geração imediata de Relatórios das infomações relavantes de cada tela. Tudo com o intuito de aprimorar a experiência do usuário.

Foi implementado o Login por biometria por meio do leitor modelo finKey Hamster DX Nitgen. Essa abordagem proporciona um nível elevado de segurança e comodidade, simplificando o acesso dos usuários de maneira confiável. Ainda no login, ao realizar o cadastro de um novo usuário, é enviado um email com o nome de usuário e senha, e ao realizar o primeiro login é solicitado a troca dessa senha. As senhas são criptografadas para garantir maior segurança no sistema. Além disso, está implementado o autopreenchimento dos dados do endereço através do CEP, integrado ao WebService dos Correios. Essa característica agiliza e aprimora o processo de inserção de informações, simplificando o preenchimento de dados de forma automática a partir do CEP inserido, melhorando a experiência do usuário e minimizando possíveis erros.

## Diagrama
O sistema implementa o Diagrama de relacionamento ilustrado na figura a seguir:

![Diagrama de Entidade Ralacionamento](https://user-images.githubusercontent.com/61707707/282452920-ee0f41ed-326d-4d32-a4b8-4a6f9059808b.png)

- Existem três tipos de usuários no sistema:
    - Cliente - Possui funcionalidades limitadas dentro da aplicação. Sua principal permissão, é a de realizar pedidos a partir dos produtos cadastrados no sistema.
    - Vendedor - Além das funcionalidade do cliente, o vendedor também é capaz de cadastrar, listar, editar, excluir e filtrar seus produtos dentro da aplicação além de poder listar os usuários que são possíveis clientes. 
    - Administrador - Possui todas as funcionalidades do sistema, inclusive àquelas exclusivas para cliente e vendedores. O usuário Administrador, é capaz de cadastrar novos usuários, assim como listá-los e excluí-los.

    Os tipo de usuário são identificados como Admin = 1, Client = 2, Seller = 3. 

    Ao executar o programa pela primeira vez, o sistema cria um usuário master para que seja possivel a inserção de novos usuários. O login inicial desse usuário é :
        - UserName : master
        - Senha : 123456

