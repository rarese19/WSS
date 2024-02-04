import axios from 'axios'

export default axios.create({
    baseURL: 'https://localhost:5093',
    withCredentials: true
})

export const fetchUsernameById = async (userId: string) => {
    try {
        const response = await axios.get(`http://localhost:5093/api/User/username?id=${userId}`);
        return response.data;
    } catch (error) {
        console.error(error);
    }
};

export const login = async (email: string, password: string) => {
    try {
        const response = await axios.post('http://localhost:5093/api/User/login', {
            email,
            password,
        });
        console.log(response.data);
        const token = response.data;
        if (token) {
            const username = await fetchUsernameById(token);
            localStorage.setItem("userName", username);
            localStorage.setItem("authToken", token);
        }
    } catch (error) {
        console.error(error);
    }
};

export const register = async (nume: string, prenume: string, userName: string, email: string, password: string) => {
    try {
        const response = await axios.post('http://localhost:5093/api/User/signup', {
            nume,
            prenume,
            userName,
            email,
            password
        });
        console.log(response.data);
    } catch (error) {
        console.error(error);
    }
}

export const partiiStatiuni = async (id: string) => {
    try {
        const response = await axios.get(`http://localhost:5093/api/Partie/partii/${id}`);
        console.log(response.data);
        return response.data;
    }
    catch (error) {
        console.error(error);
    }
}

export const allStatiuni = async () => {
    try {
        const response = await axios.get('http://localhost:5093/api/Statiune/allStatiuneInfo');
        return response.data;
    }
    catch (error) {
        console.error(error);
    }
}
