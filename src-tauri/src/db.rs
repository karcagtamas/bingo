use std::sync::Arc;
use surrealdb::engine::local::File;
use surrealdb::Surreal;
use tokio::sync::Mutex;

pub type DbConnection = Arc<Mutex<Surreal<File>>>;

pub async fn init_db() -> surrealdb::Result<DbConnection> {
    let db = Surreal::new::<File>("app.db").await?;
    db.use_ns("app").use_db("data").await?;
    Ok(Arc::new(Mutex::new(db)))
}
