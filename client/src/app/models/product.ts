export interface Product {
    id: number
    name: string
    description: string
    price: number
    pictureUrl: string
    type: string
}

export interface ProductParams {
    orderBy: string;
    searchTerm?: string;
    types: string[];
    pageNumber: number;
    pageSize: number;
}