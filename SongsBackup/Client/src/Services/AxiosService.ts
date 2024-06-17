import axios, {AxiosInstance, AxiosResponse} from "axios";

class AxiosService{
    
    private apiClient: AxiosInstance;
    
    constructor(baseUrl: string) {
        this.apiClient = axios.create({
            baseURL: baseUrl,
            headers: {
                'Content-Type': 'application/json'
            }
        });
    }
    
    public async getSomething(endpoint: string): Promise<AxiosResponse<any>>{
        return await this.apiClient.get(endpoint);
    }


}


export const axiosService = AxiosService;