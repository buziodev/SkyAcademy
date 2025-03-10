flowchart TD
    A([Início]) --> B[Tela de Login/Registro]
    B --> C{Usuário válido?}
    C -->|Sim| D[Menu Principal]
    C -->|Não| E[Exibe mensagem de erro]
    E --> B
    D --> F{Opção selecionada}
    F -->|Gerenciar Alunos| G[Tela de Gestão de Alunos]
    F -->|Sair| Z([Fim])
    
    G --> H{Operação}
    H -->|Cadastrar| I[Formulário de Cadastro]
    H -->|Atualizar| J[Formulário de Edição]
    H -->|Excluir| K[Confirmação de Exclusão]
    H -->|Voltar| D
    
    I --> L{Validação OK?}
    L -->|Sim| M[Salva no MySQL]
    L -->|Não| N[Exibe erros]
    N --> I
    M --> O[Exibe sucesso]
    O --> G
    
    J --> P{Matrícula existe?}
    P -->|Sim| Q[Preenche campos]
    Q --> R{Validação OK?}
    R -->|Sim| S[Atualiza no MySQL]
    R -->|Não| T[Exibe erros]
    T --> J
    S --> U[Exibe sucesso]
    U --> G
    P -->|Não| V[Exibe erro]
    V --> G
    
    K --> W{Confirma?}
    W -->|Sim| X[Remove do MySQL]
    W -->|Não| G
    X --> Y[Exibe sucesso]
    Y --> G
    
    style A fill:#4CAF50,stroke:#388E3C
    style B fill:#2196F3,stroke:#1976D2
    style D fill:#9C27B0,stroke:#6A1B9A
    style G fill:#FF9800,stroke:#EF6C00
    style I,J,K fill:#00BCD4,stroke:#0097A7
    style M,S,X fill:#4CAF50,stroke:#388E3C
    style E,N,V,T fill:#F44336,stroke:#D32F2F