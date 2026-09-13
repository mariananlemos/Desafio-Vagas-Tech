-- ==========================================================
-- 1: Tabela de Origem 1 (VAGAS)
-- ==========================================================
CREATE TABLE VAGAS (
    ID_VAGA INT NOT NULL,
    TITULO VARCHAR(100) NOT NULL,
    EMPRESA VARCHAR(100) NOT NULL,
    SALARIO DECIMAL NOT NULL,
    PRIMARY KEY (ID_VAGA)
);

-- ==========================================================
-- 2: Tabela de Origem 2 (CANDIDATAS)
-- ==========================================================
CREATE TABLE CANDIDATAS (
    ID_CANDIDATA INT NOT NULL,
    NOME VARCHAR(100) NOT NULL,
    EMAIL VARCHAR(100) NOT NULL,
    PRIMARY KEY (ID_CANDIDATA)
);

-- 3: Tabela Associativa N:N (CANDIDATURAS)
-- ==========================================================
CREATE TABLE CANDIDATURAS (
    ID_CANDIDATURA INT NOT NULL,
    DATA_ENVIO DATETIME NOT NULL,
    ID_VAGA INT NOT NULL,
    ID_CANDIDATA INT NOT NULL,
    PRIMARY KEY (ID_CANDIDATURA),
    FOREIGN KEY (ID_VAGA) REFERENCES VAGAS(ID_VAGA),
    FOREIGN KEY (ID_CANDIDATA) REFERENCES CANDIDATAS(ID_CANDIDATA)
);