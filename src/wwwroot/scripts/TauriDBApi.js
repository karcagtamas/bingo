const TAURI_DATABASE = window.__TAURI__.sql;

async function db() {
    return await TAURI_DATABASE.load("sqlite:app.bingo.db");
}

async function getTemplates() {
    const res = await (await db()).select('SELECT * FROM templates');

    console.log(res);

    return res;
}

async function getTemplate(id) {
    return await (await db()).select('SELECT * FROM templates WHERE id = $1', [id]);
}

async function addTemplate(data) {
    await (await db()).execute('INSERT INTO templates (id, name, group, creation, imported) VALUES ($1, $2, $3, $4)', [data.id, data.name, data.group, data.creation, data.imported]);
}

async function updateTemplate(data) {
    await (await db()).execute('UPDATE templates set name = $1, group = $2 WHERE id = $3', [data.name, data.group, data.id]);
}

async function deleteTemplate(id) {
    await (await db()).execute('DELETE FROM templates WHERE id = $1', [id]);
}