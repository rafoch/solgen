import {Card} from "@/components/ui/card";

export default function Navbar() {
    return (
        <div className={"w-full container h-20 flex justify-center items-center gap-14"}>
            <div
                className={"rounded-3xl h-12 from-[#0F6664] bg-gradient-to-r from-80% via-[#228c7c] via-95% to-100% to-[#2EB292] overflow-hidden text-black font-bold  pr-6 shadow-[#181c42] shadow-ultra"}>
                <div className={"bg-white h-12 flex items-center  gap-4 pl-2 rounded-r-3xl pr-6"}>
                    <img src={"/logo.png"} alt={"logo"} height={48} width={48}/>
                    <span className={"text-2xl uppercase"}>SOLGEN</span>
                </div>
            </div>
            <div>Navigation</div>
            <div
                className={"rounded-3xl h-12 text-white flex items-center gap-4  bg-[#0F6664] overflow-hidden font-bold pl-2 shadow-[#181c42] shadow-ultra"}>
                <span className={"pl-4 text-blue-600"}>100 commitów</span>
                <div className={"rounded-l-3xl bg-[#2ff7bc90] h-full pl-12 pr-12 flex items-center underline"}>devmentors.pl</div>
            </div>
        </div>)
}

// shadow-[#228c7c]

// bg-[#2EB292]