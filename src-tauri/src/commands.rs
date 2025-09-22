use crate::db::DbConnection;
use serde::{Deserialize, Serialize};
use serde_json::json;
use std::vec;

pub type TauriDb = tauri::State<'_, DbConnection>;

#[derive(Debug, Serialize, Deserialize)]
pub struct Template {
    pub id: String,
    pub name: String,
    pub group: String,
    pub items: Vec<String>,
}

#[tauri::comand]
pub async fn add_template(db: TauriDb, name: str) -> surrealdb::Result<Template> {
    let db = db.lock().await;
    let created: Option<Template> = db.create("template").content(json!({ "name": "" })).await?;

    Ok(created.unwrap())
}

#[tauri::command]
pub async fn get_templates(db: TauriDb) -> surrealdb::Result<Vec<Template>> {
    let db = db.lock().await;
    let templates: Vec<Template> = db.query("SELECT * from template").await?.take(0)?;
    Ok(templates);
}
