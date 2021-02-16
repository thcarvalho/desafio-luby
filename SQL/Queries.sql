-- 2.1
SELECT tabela_pessoa.pessoa_id, nome, evento
FROM tabela_pessoa
  INNER JOIN tabela_evento ON tabela_pessoa.pessoa_id = tabela_evento.pessoa_id;

-- 2.2
SELECT *
FROM tabela_pessoa
WHERE nome LIKE '%Doe%';

-- 2.3
INSERT INTO tabela_evento
  (evento, pessoa_id)
VALUES
  ('Evento E', 5);

-- 2.4
UPDATE tabela_evento 
  SET pessoa_id = 1 WHERE evento = 'Evento D';

-- 2.5
DELETE FROM tabela_evento
  WHERE evento = 'Evento B';

-- 2.6
DELETE FROM tabela_pessoa
  WHERE tabela_pessoa.pessoa_id NOT IN (SELECT pessoa_id
FROM tabela_evento);

-- 2.7
ALTER TABLE tabela_pessoa
  ADD COLUMN idade INT;

-- 2.8
CREATE TABLE IF NOT EXISTS tabela_telefone
(
  telefone_id SERIAL PRIMARY KEY,
  telefone CHAR(40),
  pessoa_id INT,
  CONSTRAINT fk_pessoaTel
    FOREIGN KEY (pessoa_id)
      REFERENCES tabela_pessoa(pessoa_id)
);

-- 2.9
ALTER TABLE tabela_telefone
  ADD CONSTRAINT unique_constraint UNIQUE(telefone);

DROP TABLE IF EXISTS tabela_telefone