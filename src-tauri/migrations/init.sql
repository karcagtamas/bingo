CREATE TABLE IF NOT EXISTS templates (
    id TEXT PRIMARY KEY,
    name TEXT NOT NULL,
    group TEXT NOT NULL,
    creation TEXT NOT NULL DEFAULT current_timestamp,
    imported INTEGER NOT NULL DEFAULT 0
);

CREATE TABLE IF NOT EXISTS template_items (
    id TEXT PRIMARY KEY,
    caption TEXT NOT NULL,
    template_id TEXT NOT NULL,
    FOREIGN KEY (template_id) REFERENCES templates (id)
);

CREATE TABLE IF NOT EXISTS games (
    id TEXT PRIMARY KEY,
    template_id TEXT NULL,
    custom INTEGER NOT NULL DEFAULT 0,
    rows INTEGER NOT NULL DEFAULT 5,
    cols INTEGER NOT NULL DEFAULT 5,
    creation TEXT NOT NULL DEFAULT current_timestamp,
    FOREIGN KEY (template_id) REFERENCES templates (id)
);

CREATE TABLE IF NOT EXISTS game_cells (
    id TEXT PRIMARY KEY,
    order_no INTEGER NOT NULL DEFAULT 0,
    checked INTEGER NOT NULL DEFAULT 0,
    joker INTEGER NOT NULL DEFAULT 0,
    caption TEXT NULL,
    game_id TEXT NOT NULL,
    FOREIGN KEY (game_id) REFERENCES games (id)
);