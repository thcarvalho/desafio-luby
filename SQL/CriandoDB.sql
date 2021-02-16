CREATE DATABASE LubyDB

CREATE TABLE IF NOT EXISTS tabela_pessoa (
  pessoa_id SERIAL PRIMARY KEY,
  nome CHAR(40) NOT NULL
);

CREATE TABLE IF NOT EXISTS tabela_evento (
  evento_id SERIAL PRIMARY KEY,
  evento CHAR(50) NOT NULL,
  pessoa_id int,
  CONSTRAINT fk_pessoa
    FOREIGN KEY (pessoa_id)
      REFERENCES tabela_pessoa(pessoa_id)
);

INSERT INTO tabela_pessoa(nome) VALUES
  ('John Doe'),
  ('Jane Doe'),
  ('Alice Jones'),
  ('Bobby Louis'),
  ('Lisa Romero');

INSERT INTO tabela_evento(evento, pessoa_id) VALUES
  ('Evento A', 2),
  ('Evento B', 3),
  ('Evento C', 2),
  ('Evento D', NULL);