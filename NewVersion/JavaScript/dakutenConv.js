function dakuten(arg){
    return [...arg].map((a) => {
        const normalize = a.normalize("NFD")
        return normalize.length > 1 ? normalize : `${normalize}゛`;
    }).join('')
}

console.log(dakuten("だくてんテスト"));
