import type { Metadata } from "next";
import { Inter } from "next/font/google";
import "./globals.css";
import Sidebar from "@/components/Sidebar/Sidebar";
import Navbar from "@/components/Navbar/Navbar";

const inter = Inter({ subsets: ["latin"] });

export const metadata: Metadata = {
  title: "SOLGEN",
  description: "Open Source solution generation tool",
  icons: [
    {
      url: "/logo.png"
    }
  ]
};

export default function RootLayout({
  children,
}: Readonly<{
  children: React.ReactNode;
}>) {
  return (
    <html lang="en">
      <body className={inter.className}>
      <div className={"background-circle"}></div>
        <main className={"content h-full"}>
          <div className={"flex gap-x-3 h-full"}>
            {/*<Sidebar/>*/}
            
            <div className={"h-full flex-1"}>
              <Navbar/>
              {children}
              
            </div>
          </div>
        </main>
      </body>
    </html>
  );
}

// bg-gradient-to-t from-[#201d3c] from-70% via-10% to-100% to-[#0f6664]
