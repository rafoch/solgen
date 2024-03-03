"use client";
import {useEffect, useState} from "react";
import Editor, {useMonaco} from '@monaco-editor/react';
export default function TextEditor(){
    
    const [value, setValue] = useState("sln SolutionName {\n" +
        "   folder DummyFolder {\n" +
        "       csharp ProjectName {\n" +
        "\n" +
        "       }\n" +
        "\n" +
        "       csharp SecondProject {\n" +
        "\n" +
        "        }\n" +
        "   }\n" +
        "   csharp ExampleProject {\n" +
        "\n" +
        "   }\n" +
        "   \n" +
        "   folder NewFolder {\n" +
        "   \n" +
        "   } \n" +
        "} ")
    
    const monaco = useMonaco();
    
    monaco?.languages.register({id: 'slg'})

    monaco?.editor.defineTheme('slg', {
        base: 'vs',
        inherit: true,
        rules: [
            {
                token: 'keyword',
                foreground: '#A020F0'
            },
            {
                token: 'type.identifier',
                foreground: "#ffffff"
            },
            {
                token: '@brackets',
                foreground: '#ffffff'
            },
            
        ],
        colors: {
            'editor.background': '#0F666405',
            'editor.foreground': '#aaaabc',
            
        }
    })
    
    monaco?.languages.setMonarchTokensProvider('slg', {
        keywords: [ 'sln', 'folder', 'csharp' ],
        typeKeywords: ['sln', 'folder', 'folder'],
        symbols:  /[=><!~?:&|+\-*\/\^%]+/,
        escapes: /\\(?:[abfnrtv\\"']|x[0-9A-Fa-f]{1,4}|u[0-9A-Fa-f]{4}|U[0-9A-Fa-f]{8})/,
        tokenizer: {
            root: [
                [/[a-z_$][\w$]*/, { cases: { '@typeKeywords': 'keyword',
                        '@keywords': 'keyword',
                        '@default': 'identifier' } }],
                [/[A-Z][\w\$]*/, 'type.identifier' ],

                { include: '@whitespace' },

                [/[{}()\[\]]/, '@brackets'],
                [/[<>](?!@symbols)/, '@brackets'],

                [/"([^"\\]|\\.)*$/, 'string.invalid' ],  // non-teminated string
                [/"/,  { token: 'string.quote', bracket: '@open', next: '@string' } ],

                // characters
                [/'[^\\']'/, 'string'],
                [/(')(@escapes)(')/, ['string','string.escape','string']],
                [/'/, 'string.invalid']
                
            ],

            string: [
                [/[^\\]+/,  'string'],
                [/@escapes/, 'string.escape'],
                [/\\./,      'string.escape.invalid'],
            ],
            
            whitespace: [
                [/[ \t\r\n]+/, 'white']
            ],
           
        }
    })

    
        useEffect(() => {
          
        }, []);


        return (
            <div id={"container"} style={{height: '100%'}}>
                <Editor
                    theme={"slg"}
                    height={"70vh"} language={"slg"} value={value} onChange={(e) => {
                    const val = e ?? ""; 
                    setValue(val);
                }} 
                
                        options={{
                            fontSize: 18
                        }}
                />
            </div>
        )
    
}