mod commands;
mod db;

use crate::commands::{add_template, get_templates};
use crate::db::init_db;

#[cfg_attr(mobile, tauri::mobile_entry_point)]
pub fn run() {
    tauri::Builder::default()
        .plugin(tauri_plugin_opener::init())
        .manage(
            tokio::runtime::Runtime::new()
                .unwrap()
                .block_on(init_db())
                .unwrap(),
        )
        .invoke_handler(tauri::generate_handler![add_template, get_templates])
        .run(tauri::generate_context!())
        .expect("error while running tauri application");
}
