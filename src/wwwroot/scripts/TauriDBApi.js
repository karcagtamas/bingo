const TAURI_DATABASE = window.__TAURI__.sql;

async function db() {
    return await TAURI_DATABASE.load("sqlite:app.bingo.db");
}

function mapTemplate(obj) {
    return {
        ...obj,
        imported: obj.imported === "true",
    };
}

function mapGame(obj) {
    return {
        ...obj,
        template_id: parseInt(obj.template_id, 10),
        custom: obj.custom === "true",
        rows: parseInt(obj.rows, 10),
        cols: parseInt(obj.cols, 10),
    };
}

async function getTemplates() {
    const res = await (await db()).select('SELECT * FROM templates');

    return res.map(mapTemplate);
}

async function getTemplate(id) {
    const res = await (await db()).select('SELECT * FROM templates WHERE id = $1', [id]);
    
    return mapTemplate(res);
}

async function addTemplate(data) {
    await (await db()).execute('INSERT INTO templates (id, name, grp, creation, imported) VALUES ($1, $2, $3, $4, $5)', [data.id, data.name, data.grp, data.creation, data.imported]);
}

async function updateTemplate(data) {
    await (await db()).execute('UPDATE templates set name = $1, grp = $2 WHERE id = $3', [data.name, data.grp, data.id]);
}

async function deleteTemplate(id) {
    await (await db()).execute('DELETE FROM templates WHERE id = $1', [id]);
}


async function getGame() {
    const res = await (await db()).select('SELECT * FROM games');

    return res.map(mapGame);
}

async function getGame(id) {
    const res = await (await db()).select('SELECT * FROM games WHERE id = $1', [id]);

    return mapGame(res);
}

async function addGame(data) {
    await (await db()).execute('INSERT INTO games (id, caption, template_id, custom, rows, cols, creation) VALUES ($1, $2, $3, $4, $5, $6, $7)', [data.id, data.caption, data.template_id, data.custom, data.rows, data.cols, data.creation]);
}

async function updateGame(data) {
    await (await db()).execute('UPDATE games set caption = $1, custom = $2, rows = $3, cols = $4 WHERE id = $5', [data.caption, data.custom, data.rows, data.cols, data.id]);
}

async function deleteGame(id) {
    await (await db()).execute('DELETE FROM games WHERE id = $1', [id]);
}