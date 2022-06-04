pub trait Persistence {
  fn read(table: &str, id: &str, cell: &str) -> Result<String, String>;
  fn write(table: &str, id: &str, cell: &str) -> Result<String, String>;
}
