# 🎓 Sky Academy - Sistema de Gestão Acadêmica

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![MySQL](https://img.shields.io/badge/MySQL-005C84?style=for-the-badge&logo=mysql&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)

Sistema de cadastro e gerenciamento de alunos para a **Sky Academy**, uma instituição de ensino técnico-profissionalizante.

---

## 📌 Introdução
O **Sky Academy** é um sistema desktop desenvolvido em C# (.NET Windows Forms) com integração a banco de dados MySQL, projetado para simplificar a gestão de alunos, incluindo:
- Cadastro completo de alunos
- Atualização e exclusão de registros
- Consulta intuitiva de dados
- Validação de campos críticos (CPF, telefone)

---

## 🚀 Funcionalidades
| Funcionalidade         | Descrição                                                          |
|------------------------|--------------------------------------------------------------------|
| 📥 Cadastro de Alunos  | Insere dados pessoais, de contato e acadêmicos.                   |
| ✏️ Atualização         | Edita informações via matrícula.                                  |
| 🗑️ Exclusão Segura     | Remove registros com confirmação.                                 |
| 🔍 Consulta Rápida     | Visualização em tabela interativa (`DataGridView`).               |

---

## 🛠️ Tecnologias
| Tecnologia             | Uso                                                               |
|------------------------|-------------------------------------------------------------------|
| ![C#](https://img.shields.io/badge/C%23-239120?style=flat-square&logo=c-sharp&logoColor=white) | Lógica de negócios e interface. |
| ![MySQL](https://img.shields.io/badge/MySQL-005C84?style=flat-square&logo=mysql&logoColor=white) | Armazenamento de dados.         |
| ![.NET](https://img.shields.io/badge/.NET-512BD4?style=flat-square&logo=dotnet&logoColor=white) | Framework para desenvolvimento. |

---

## ⚙️ Configuração

### Pré-requisitos
- [.NET Framework 4.8+](https://dotnet.microsoft.com/download/dotnet-framework)
- [MySQL Server](https://dev.mysql.com/downloads/mysql/)
- [MySQL Connector/NET](https://dev.mysql.com/downloads/connector/net/)

### Banco de Dados
```sql
CREATE DATABASE db_skyacademy;

CREATE TABLE cadastro(
    id INT PRIMARY KEY AUTO_INCREMENT,
    email VARCHAR(60) UNIQUE,
    nome VARCHAR(80),
    senha VARCHAR(50),
);

CREATE TABLE Alunos (
    id INT PRIMARY KEY AUTO_INCREMENT,
    matricula VARCHAR(20) UNIQUE NOT NULL,
    nome_completo VARCHAR(100) NOT NULL,
    data_nascimento DATE NOT NULL,
    cpf VARCHAR(14) UNIQUE NOT NULL,
    endereco VARCHAR(200) NOT NULL,
    telefone VARCHAR(20) NOT NULL,
    email VARCHAR(100) NOT NULL,
    turma VARCHAR(10) NOT NULL,
    data_matricula DATE DEFAULT CURRENT_DATE,
    situacao ENUM('Ativo', 'Transferido', 'Trancado', 'Formado') DEFAULT 'Ativo'
);

```

---

## 🌐 Fluxograma