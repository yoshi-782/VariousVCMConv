function dakuten(arg){
    return [...arg].map((a) => {
        const normalize = a.normalize("NFD")
        return normalize.length > 1 ? `${normalize.substring(0, 1)}゛` : `${normalize}゛`;
    }).join('')
}

console.log(dakuten("だくてんテスト"));
