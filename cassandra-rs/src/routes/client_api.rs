#[get("/<table>/<id>/<cell>")]
pub fn get(table: &str, id: &str, cell: &str) -> String {
    format!("Getting cell {} of key {} in table {}", cell, id, table)
}
