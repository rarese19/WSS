import axios from 'axios'

export default axios.create({
    baseURL: 'https://localhost:5093',
    withCredentials: true
})

export const login = async (email: string, password: string) => {
    try {
        const response = await axios.post('http://localhost:5093/api/User/login', {
            email,
            password,
        });
        console.log(response.data);
    } catch (error) {
        console.error(error);
    }
};
