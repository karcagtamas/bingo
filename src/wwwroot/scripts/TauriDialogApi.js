const TAURI_DIALOG = window.__TAURI__.dialog;

async function tauri__showMessage(message, options) {
    const {message: show} = TAURI_DIALOG;

    return await show(message, options);
}

async function tauri__ask(message, options) {
    const {ask} = TAURI_DIALOG;

    return await ask(message, options);
}

async function tauri__confirm(message, options) {
    const {confirm} = TAURI_DIALOG;

    return await confirm(message, options);
}

async function tauri__openFileDialog(options) {
    const {open} = TAURI_DIALOG;

    return await open(options);
}

async function tauri__saveFileDialog(options) {
    const {save} = TAURI_DIALOG;

    return await save(options);
}