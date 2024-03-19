import TextEditor from "@/components/Editor/TextEditor";
export const runtime = "edge";
import {getTokens} from "@/api/getTokens";
import {DiagramDrawer} from "@/components/DiagramDrawer/DiagramDrawer";

export default async function Page(){
    
    const newVar = await getTokens();
    
    return (
        <div className={"pt-4 flex items-center justify-between w-full"}>
            <div className={"w-full"}>
                <TextEditor/>
            </div>
            <div className={"w-full"}>
                <DiagramDrawer/>
            </div>
        
        </div>)
}