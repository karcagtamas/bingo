const TAURI_DIALOG = window.__TAURI__.dialog;

async function tauri__showMessage(message, title = "Info") {
    const { message: show } = TAURI_DIALOG;

    return await show(message, { title });
}

async function tauri__ask(message, title = "Info") {
    const { ask } = TAURI_DIALOG;

    return await ask(message, { title });
}

async function tauri__confirm(message, title = "Info") {
    const { confirm } = TAURI_DIALOG;

    return await confirm(message, { title });
}

async function tauri__openFileDialog(options) {
    const { open } = TAURI_DIALOG;

    return await open(options);
}

async function tauri__saveFileDialog(options) {
    const { save } = TAURI_DIALOG;

    return await save(options);
}