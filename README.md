# Aplicação Angular com API em .NET para Gerenciamento de Pessoas

## Descrição

Este projeto consiste em uma aplicação Angular que consome uma API em .NET para gerenciamento de pessoas. O foco do projeto está na comunicação eficiente entre o frontend Angular e a API RESTful backend.



## Tecnologias Utilizadas

- **Backend:** .NET 9, C#

- **Frontend:** Angular, TypeScript

- **Banco de Dados:** Simulação em memória (lista de objetos)

  

## Funcionalidades Implementadas

- **API REST em .NET** com endpoints para gerenciamento de pessoas (cadastro, listagem, busca e edição).

- **Consumo da API via Angular** utilizando `HttpClient`, com tratamento de respostas assíncronas.

- **Utilização de Observables e Subjects** no frontend para atualização dinâmica da interface.

- **Serviços no Angular** para centralizar chamadas à API e organizar o código.

  

## Como Executar o Projeto

### Backend (.NET API)

1. Clone o repositório:

   ```sh
   git clone https://github.com/seu-usuario/AngularApi.git
   ```

2. Navegue até o diretório do backend:

   ```sh
   cd backend-api
   ```

3. Instale as dependências e execute a API:

   ```sh
   dotnet run
   ```

### Frontend (Angular)

1. Navegue até o diretório do frontend:

   ```sh
   cd frontend-api
   ```

2. Instale as dependências:

   ```sh
   npm install
   ```

3. Execute o projeto:

   ```sh
   ng serve
   ```

4. Acesse a aplicação no navegador:

   ```
   http://localhost:4200
   ```
