# 📚 Sistema de Gerenciamento de Biblioteca  

Este é um sistema de gerenciamento de biblioteca desenvolvido em **C#** utilizando **ASP.NET Core** com o padrão **MVC**. O sistema é projetado para gerenciar um acervo de livros, permitindo que usuários possam reservar e devolver exemplares diretamente pela plataforma. Além disso, oferece um painel administrativo para gerenciar o catálogo de livros.

---

## 🚀 **Funcionalidades**  

### 🧑‍💻 **Usuário Padrão**
- **Cadastro e Login**: Permite que novos usuários se registrem e façam login.
- **Reserva de Livros**: Usuários autenticados podem reservar livros disponíveis.
- **Devolução de Livros**: Possibilidade de devolver livros previamente reservados.

### 🔑 **Administração**
- **Gerenciamento de Livros** (somente para administradores):
  - Adicionar novos livros ao acervo.
  - Editar informações dos livros (título, autor, ano e disponibilidade).
  - Excluir livros do catálogo.
- Controle baseado em **roles** para diferenciar usuários e administradores.

### 💻 **Interface Responsiva**
- Interface desenvolvida com **Bootstrap**, garantindo:
  - Navegação amigável e responsiva para dispositivos móveis, tablets e desktops.
  - Elementos intuitivos, como botões, tabelas e formulários.

---

## 🛠️ **Tecnologias Utilizadas**
- **Linguagem**: C#
- **Framework**: ASP.NET Core MVC
- **Banco de Dados**: SQLite
- **Estilização**: Bootstrap 5
- **Autenticação**: Identity do ASP.NET Core  

---

## ⚙️ **Configuração e Execução**

### **1. Pré-requisitos**
- **SDK .NET** (versão 7.0 ou superior).
- Editor de código como **Visual Studio** ou **Visual Studio Code**.

### **2. Clone o Repositório**
```bash
git clone https://github.com/Jjunior112/LibraryManager
cd sistema-biblioteca
```

### **3. Configure o Banco de Dados**
Execute as migrações para configurar o banco de dados:
```bash
dotnet ef database update
```

### **4. Execute o Projeto**
Inicie o servidor:
```bash
dotnet run
```
Acesse o sistema no navegador: `https://localhost:5---`.

---

## 🔐 **Acessos Padrão**
- **Administrador**:
  - E-mail: `admin@admin.com`
  - Senha: `Admin@123`

- **Usuário Padrão**: Crie uma conta diretamente na plataforma.




