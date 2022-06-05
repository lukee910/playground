use crate::model::{RowMutation};
// use crate::persitence::Persistence;
use rocket::serde::json::Json;

#[get("/<table>/<id>/<cell>")]
pub fn get(table: &str, id: &str, cell: &str) -> String {
    format!("Getting cell {} of key {} in table {}", cell, id, table)
}

#[post("/<table>/<id>", format = "json", data = "<mutationJson>")]
pub fn post(table: &str, id: &str, mutationJson: Json<RowMutation>) -> String {
    let mutation = mutationJson.into_inner();
    format!("Temp")
}
