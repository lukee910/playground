use crate::model::{RowMutation};
// use crate::persitence::Persistence;
use rocket::serde::json::Json;

#[get("/<table>/<id>/<cell>")]
pub fn get(table: &str, id: &str, cell: &str) -> String {
    format!("Getting cell {} of key {} in table {}", cell, id, table)
}

#[post("/<table>/<id>", format = "json", data = "<mutation_json>")]
pub fn post(table: &str, id: &str, mutation_json: Json<RowMutation>) -> String {
    let _mutation = mutation_json.into_inner();
    format!("Temp {} {}", table, id)
}
