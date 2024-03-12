import {Card} from "@/components/ui/card";
import Link from "next/link";

export default function Navbar() {
    return (
        <div className={"w-full container h-20 flex justify-center items-center gap-14"}>
            {/* LOGO section */}
            <div
                className={"rounded-3xl h-12 from-[#0F6664] bg-gradient-to-r from-80% via-[#228c7c] via-95% to-100% to-[#2EB292] overflow-hidden text-black font-bold  pr-6 shadow-[#181c42] shadow-ultra"}>
                <div className={"bg-white h-12 flex items-center  gap-4 pl-2 rounded-r-3xl pr-6"}>
                    <img src={"/logo.png"} alt={"logo"} height={48} width={48}/>
                    <span className={"text-2xl uppercase"}>SOLGEN</span>
                </div>
            </div>
            {/* NAVIGATION SECTION */}
            <div className={"flex gap-12"}>
                <Link href={"/"} className={"uppercase font-semibold underline underline-offset-4"}>Try it out</Link>
                <Link href={"/about"} className={"uppercase font-semibold underline underline-offset-4"}>About</Link>
            </div>
            
            {/* EXTERNAL LINKS SECTION */}
            <div
                className={"rounded-3xl h-12 text-white flex items-center gap-4  bg-[#0F6664] overflow-hidden font-bold pl-2 shadow-[#181c42] shadow-ultra"}>
                <Link  href="https://100commitow.pl" target={"_blank"} className={"pl-4 text-white underline"}>100 commitów</Link>
                <Link href="https://devmentors.io" target={"_blank"} className={"rounded-l-3xl bg-[#2ff7bc90] h-full pl-12 pr-12 flex items-center underline"}>devmentors.io</Link>
            </div>
        </div>)
}