mod model;
mod persitence;
mod routes;

#[macro_use]
extern crate rocket;

#[get("/")]
fn index() -> &'static str {
    "Hello, world!"
}

#[launch]
fn rocket() -> _ {
    rocket::build().mount("/", routes![index]).mount(
        "/api/",
        routes![routes::client_api::get, routes::client_api::post],
    )
}
