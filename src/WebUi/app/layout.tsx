import type { Metadata } from "next";
import { Inter } from "next/font/google";
import "./globals.css";
import Navbar from "@/components/Navbar/Navbar";

const inter = Inter({ subsets: ["latin"] });

export const metadata: Metadata = {
  title: "SOLGEN",
  description: "Free solution generation tool",
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
            <div className={"h-full flex-1 flex flex-col gap-6"}>
              <Navbar/>
              {children}
            </div>
          </div>
        </main>
      </body>
    </html>
  );
}