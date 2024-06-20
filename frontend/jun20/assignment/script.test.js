const validation = require('./script')

const {JSDOM} = require('jsdom');
const fs = require('fs');
const path = require('path');

// test('simple button click',()=>{
//     const html = fs.readFileSync(path.resolve(__dirname,'./login.html'),'utf8');
//     const script = fs.readFileSync(path.resolve(__dirname,'./script.js'),'utf8');
    
//     const dom = new JSDOM(html,{runScripts: 'dangerously',resources: 'usable'});
//     const scriptElement = dom.window.document.createElement('script');
//     scriptElement.textContent = script;
//     dom.window.document.body.appendChild(scriptElement);
// })


    describe("validation", () => {
        test("returns true if validation is success", () => {
          expect(validation("mv@gmail.com", "1234")).toBe(true);
        });  
        test("returns true if validation is success", () => {
          expect(validation("mv@gmail.com", "12345")).toBe(false);
        });  
    }) 