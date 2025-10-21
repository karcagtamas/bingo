const TAURI_DATABASE = window.__TAURI__.sql;

async function database() {
    return await TAURI_DATABASE.load("sqlite:app.bingo.db");
}

function mapTemplate(obj, templateItems) {
    return {
        ...obj,
        imported: obj.imported === "true",
        items: templateItems,
    };
}

function mapTemplateItem(obj) {
    return {
        ...obj,
    }
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
    const res = await (await database()).select('SELECT * FROM templates');

    return Promise.all(res.map(async x => mapTemplate(x, await getTemplateItems(x['id']))));
}

async function getTemplate(id) {
    const res = await (await database()).select('SELECT * FROM templates WHERE id = $1', [id]);

    return mapTemplate(res, await getTemplateItems(id));
}

async function getTemplateItems(templateId) {
    const res = await (await database()).select('SELECT * FROM template_items WHERE template_id = $1', [templateId]);

    return res.map(mapTemplateItem);
}

async function addTemplate(data) {
    await (await database()).execute('INSERT INTO templates (id, name, grp, creation, imported) VALUES ($1, $2, $3, $4, $5)', [data.id, data.name, data.grp, data.creation, data.imported]);
    await updateTemplateItems(data['items'], data['id']);
}

async function updateTemplate(data) {
    await (await database()).execute('UPDATE templates set name = $1, grp = $2 WHERE id = $3', [data.name, data.grp, data.id]);
    await updateTemplateItems(data['items'], data['id']);
}

async function updateTemplateItems(templateItems, templateId) {
    const db = await database();
    await db.execute('DELETE FROM template_items WHERE template_id = $1', [templateId]);
    console.log(templateItems);
    for (const item of templateItems) {
        await db.execute('INSERT INTO template_items (id, caption, template_id) VALUES ($1, $2, $3)', [item.id, item.caption, item.templateId]);
    }
}

async function deleteTemplate(id) {
    const db = await database();
    await db.execute('DELETE FROM template_items WHERE template_id = $1', [id]);
    await db.execute('DELETE FROM templates WHERE id = $1', [id]);
}

async function getGames() {
    const res = await (await database()).select('SELECT * FROM games');

    return res.map(mapGame);
}

async function getGame(id) {
    const res = await (await database()).select('SELECT * FROM games WHERE id = $1', [id]);

    return mapGame(res);
}

async function addGame(data) {
    await (await database()).execute('INSERT INTO games (id, caption, template_id, custom, rows, cols, creation) VALUES ($1, $2, $3, $4, $5, $6, $7)', [data.id, data.caption, data.template_id, data.custom, data.rows, data.cols, data.creation]);
}

async function updateGame(data) {
    await (await database()).execute('UPDATE games set caption = $1, custom = $2, rows = $3, cols = $4 WHERE id = $5', [data.caption, data.custom, data.rows, data.cols, data.id]);
}

async function deleteGame(id) {
    await (await database()).execute('DELETE FROM games WHERE id = $1', [id]);
}