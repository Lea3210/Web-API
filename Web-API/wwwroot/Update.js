
const user1 = JSON.parse(sessionStorage.getItem("user"));

const name = document.querySelector("#name").value
const lastName = document.querySelector("#lastName").value
const password = document.querySelector("#password").value
const email = document.querySelector("#email").value



email.value = user1.email;
password.value = user1.password;
name.value = user1.name;
lastName.value = user1.lastName;


const update = async () => {
    const id= user1.id
    const name = document.querySelector("#name").value
    const lastName = document.querySelector("#lastName").value
    const password = document.querySelector("#password").value
    const email = document.querySelector("#email").value

    const updateUser = {

        name :name || user1.name, lastName: lastName ||user1.lastName, password: password || user1.password,email: email|| user1.email
    }

    try {
        const response = await fetch(`api/Users/${id}`, {
            method: "PUT",
            body: JSON.stringify(updateUser),
            headers: { 'Content-Type': "application/json" }
        })

        if (!response.ok)
            throw new Error("error upate details");

        else {
            sessionStorage.setItem("user",JSON.stringify(updateUser))
            alert("your details upduserate")
        }
    }

    catch (e) {
        alert(e.message)
    }
}