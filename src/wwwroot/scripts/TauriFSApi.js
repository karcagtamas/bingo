const TAURI_FS = window.__TAURI__.fs;

async function tauri__copyFile(fromPath, toPath, options) {
    const {copyFile} = TAURI_FS;

    await copyFile(fromPath, toPath, options);
}

async function tauri__create(path, options) {
    const {create} = TAURI_FS;

    return await create(path, options);
}

async function tauri__exists(path, options) {
    const {exists} = TAURI_FS;

    return await exists(path, options);
}

async function tauri__lstat(path, options) {
    const {lstat} = TAURI_FS;

    return await lstat(path, options);
}

async function tauri__mkdir(path, options) {
    const {mkdir} = TAURI_FS;

    await mkdir(path, options);
}

async function tauri__open(path, options) {
    const {open} = TAURI_FS;

    return await open(path, options);
}

async function tauri__readDir(path, options) {
    const {readDir} = TAURI_FS;

    return await readDir(path, options);
}

async function tauri__readFile(path, options) {
    const {readFile} = TAURI_FS;

    return await readFile(path, options);
}

async function tauri__readTextFile(path, options) {
    const {readTextFile} = TAURI_FS;

    return await readTextFile(path, options);
}

async function tauri__readTextFileLines(path, options) {
    const {readTextFileLines} = TAURI_FS;

    return await readTextFileLines(path, options);
}

async function tauri__remove(path, options) {
    const {remove} = TAURI_FS;

    await remove(path, options);
}

async function tauri__rename(oldPath, newPath, options) {
    const {rename} = TAURI_FS;

    await rename(oldPath, newPath, options);
}

async function tauri__size(path) {
    const {size} = TAURI_FS;

    return await size(path);
}

async function tauri__stat(path, options) {
    const {stat} = TAURI_FS;

    return await stat(path, options);
}

async function tauri__truncate(path, len, options) {
    const {truncate} = TAURI_FS;

    await truncate(path, len, options);
}

async function tauri__writeFile(path, data, options) {
    const {writeFile} = TAURI_FS;

    await writeFile(path, data, options);
}

async function tauri__writeTextFile(path, data, options) {
    const {writeTextFile} = TAURI_FS;

    await writeTextFile(path, data, options);
}