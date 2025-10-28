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
        templateId: parseInt(obj.template_id, 10),
        custom: obj.custom === "true",
        rows: parseInt(obj.rows, 10),
        cols: parseInt(obj.cols, 10),
    };
}

function mapGameCell(obj) {
    return {
        ...obj,
        orderNo: parseInt(obj.order_no, 10),
        checked: obj.checked === "true",
        joker: obj.joker === "true",
        gameId: obj.game_id,
    }
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
    for (const item of templateItems) {
        await db.execute('INSERT INTO template_items (id, caption, template_id) VALUES ($1, $2, $3)', [item.id, item.caption, item.templateId]);
    }
}

async function deleteTemplate(id) {
    const db = await database();
    await db.execute('UPDATE games WHERE template_id = $1 SET template_id = $2', [id, null])
    await db.execute('DELETE FROM template_items WHERE template_id = $1', [id]);
    await db.execute('DELETE FROM templates WHERE id = $1', [id]);
}

async function getGames() {
    const res = await (await database()).select('SELECT * FROM games');

    return Promise.all(res.map(async x => mapGame(x, await getGameCells(x['id']))));
}

async function getGame(id) {
    const res = await (await database()).select('SELECT * FROM games WHERE id = $1', [id]);

    return mapGame(res, await getGameCells(id));
}

async function getGameCells(gameId) {
    const res = await (await database()).select('SELECT * FROM game_cells WHERE game_id = $1', [gameId]);

    return res.map(mapGameCell);
}

async function addGame(data) {
    await (await database()).execute('INSERT INTO games (id, caption, template_id, custom, rows, cols, creation) VALUES ($1, $2, $3, $4, $5, $6, $7)', [data.id, data.caption, data.templateId, data.custom, data.rows, data.cols, data.creation]);
    await updateGameCells(data['cells'], data['id']);
}

async function updateGame(data) {
    await (await database()).execute('UPDATE games set caption = $1, custom = $2, rows = $3, cols = $4 WHERE id = $5', [data.caption, data.custom, data.rows, data.cols, data.id]);
    await updateGameCells(data['cells'], data['id']);
}

async function updateGameCells(gameCells, gameId) {
    const db = await database();
    await db.execute('DELETE FROM game_cells WHERE game_id = $1', [gameId]);
    for (const cell of gameCells) {
        await db.execute('INSERT INTO game_cells (id, order_no, checked, joker, caption, game_id) VALUES ($1, $2, $3)', [cell.id, cell.orderNo, cell.checked, cell.joker, cell.caption, cell.gameId]);
    }
}

async function deleteGame(id) {
    const db = await database();
    await db.execute('DELETE FROM game_cells WHERE game_id = $1', [id]);
    await db.execute('DELETE FROM games WHERE id = $1', [id]);
}