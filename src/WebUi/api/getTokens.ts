'use server'
import getHostUrl from "@/api/getHostUrl";

export async function getTokens(){
    const response = await fetch(getHostUrl() + '/available-tokens')

    const result = await response.json();
    
    return result;
}