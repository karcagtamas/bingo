const TAURI_DATABASE = window.__TAURI__.sql;

async function db() {
    return await TAURI_DATABASE.load("sqlite:app.bingo.db");
}

function mapTemplate(obj) {
    return {
        ...obj,
        imported: obj.imported === "true",
    }
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