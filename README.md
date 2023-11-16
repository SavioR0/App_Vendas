# Savio's Vendas

A aplicação Savio's Vendas, desenvolvida em Linguagem C# no .NET Framework 4.7.2, adota o padrão de projeto FluentAPI com camadas bem definidas e desacopladas, permitindo uma manutenção mais simples e a implementação de novos recursos de maneira organizada e eficiente. Além disso, utilizou-se o SQLServer com EntityFramework para lidar com o banco de dados relacional. 

## Organização
A seguir, têm-se a organização do projeto:

- Vendas
    - Vendas.Communication
    - Vendas.Entity
    - Vendas.Infrastructure
    - Vendas.Library
    - Vendas.Management
    - Vendas.Repository
    - Vendas.Service
    - Vendas.View
## Objetivo
Seu propósito principal é gerenciar de forma eficiente usuários, produtos e pedidos. A tarefa é facilitada com a geração imediata de Relatórios das infomações relavantes de cada tela. Tudo com o intuito de aprimorar a experiência do usuário.

Foi implementado o Login por biometria por meio do leitor modelo finKey Hamster DX Nitgen. Essa abordagem proporciona um nível elevado de segurança e comodidade, simplificando o acesso dos usuários de maneira confiável. Além disso, o autopreenchimento dos dados do endereço através do CEP, integrando o WebService dos Correios. Essa característica agiliza e aprimora o processo de inserção de informações, simplificando o preenchimento de dados de forma automática a partir do CEP inserido, melhorando a experiência do usuário e minimizando possíveis erros.

## Diagrama
O sistema implementa o Diagrama de relacionamento ilustrado na figura a seguir:

![Diagrama de Entidade Ralacionamento](https://user-images.githubusercontent.com/61707707/282452920-ee0f41ed-326d-4d32-a4b8-4a6f9059808b.png)

- Existem três tipos de usuários no sistema:
    - Cliente - Possui funcionalidades limitadas dentro da aplicação. Sua principal permissão, é a de realizar pedidos a partir dos produtos cadastrados no sistema.
    - Vendedor - Além das funcionalidade do cliente, o vendedor também é capaz de cadastrar, listar, editar, excluir e filtrar seus produtos dentro da aplicação além de poder listar os usuários que são possíveis clientes. 
    - Administrador - Possui todas as funcionalidades do sistema, inclusive àquelas exclusivas para cliente e vendedores. O usuário Administrador, é capaz de cadastrar novos usuários, assim como listá-los e excluí-los.

    Os tipo de usuário são identificados como Admin = 1, Client = 2, Seller = 3. 

