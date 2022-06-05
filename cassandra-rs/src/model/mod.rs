use rocket::serde::Deserialize;

#[derive(Deserialize)]
pub struct CellMutation {
  family: String,
  cell: String,
  value: String
}

#[derive(Deserialize)]
pub struct RowMutation {
  values: Vec<CellMutation>
  // value: String
}
