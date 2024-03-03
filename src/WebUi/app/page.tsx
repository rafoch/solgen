export const runtime = "edge";

import {getTokens} from "@/api/getTokens";
export default async function Page(){
    
    const newVar = await getTokens();
    
    return (
    <div className={"pt-4 flex items-center justify-between w-full"}>
        <div className={"w-full"}>Diagram</div>
        <div className={"w-full"}>Editor</div>
        <div>{JSON.stringify(newVar)}</div>
    </div>)
}