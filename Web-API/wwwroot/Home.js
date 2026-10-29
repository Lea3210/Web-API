
const butt = document.querySelector("#butt");
const post = async () => {
    const name = document.querySelector("#name").value
    const lastName = document.querySelector("#lastName").value
    const password = document.querySelector("#password").value
    const email = document.querySelector("#email").value

    const user = {
        name, lastName, password, email
    }

    try {
        const response = await fetch("api/Users", {
            method: "POST",
            body: JSON.stringify(user),
            headers: { 'Content-Type': "application/json" }
        })

        if (!response.ok)
            throw new Error("error adding details");

        else
            alert("your sign was success")
    }

    catch (e) {
        alert(e.message)
    }
}


const login = async () => {
    const lpassword = document.querySelector("#lpassword").value
    const lemail = document.querySelector("#lemail").value

    const user = {
        lpassword, lemail
    }

    try {
        const response = await fetch("api/Users/login", {
            method: "POST",
            body: JSON.stringify(user),
            headers: { 'Content-Type': "application/json" }    
        })

        if (!response.ok) {
            throw new Error("error found details");

        }

        else {
            alert("your details found")
            const user = await response.json();
            sessionStorage.setItem("user", JSON.stringify(user));
        }
    }

    catch (e) {
        alert(e.message)
    }
}



const strongPassword = async () => {
    const password = document.querySelector("#password").value

    try {
        const response = await fetch("api/Password", {
            method: "POST",
            body: JSON.stringify(password),
            headers: { 'Content-Type': "application/json" }
        })

        if (!response.ok)
            throw new Error("error to check");

        else {
            alert("check your password...")
            const score = await response.json(); 
            document.querySelector("#graf").value = score;


        }
    }

    catch (e) {
        alert(e.message)
    }

}
