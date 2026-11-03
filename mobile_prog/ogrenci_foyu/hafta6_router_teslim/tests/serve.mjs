import http from 'node:http';
import { readFile, stat } from 'node:fs/promises';
import path from 'node:path';
import { fileURLToPath } from 'node:url';
const root = fileURLToPath(new URL('../', import.meta.url));
export const apps = ['ariza_takip', 'urun_katalogu', 'ders_programi', 'gorev_takip'];
export async function startServers() {
 const servers = [];
 for (const [index, app] of apps.entries()) {
  const directory = path.join(root, 'apps', app, 'dist');
  const server = http.createServer(async (req, res) => {
   try {
    const pathname = decodeURIComponent(new URL(req.url, 'http://localhost').pathname);
    let target = path.resolve(directory, '.' + pathname);
    if (!target.startsWith(directory + path.sep) && target !== directory) { res.writeHead(403); res.end(); return; }
    try { if (!(await stat(target)).isFile()) target = path.join(directory, 'index.html'); } catch { target = path.join(directory, 'index.html'); }
    const types = { '.html': 'text/html; charset=utf-8', '.js': 'application/javascript', '.css': 'text/css', '.png': 'image/png', '.ttf': 'font/ttf', '.json': 'application/json', '.ico': 'image/x-icon' };
    res.writeHead(200, { 'Content-Type': types[path.extname(target)] || 'application/octet-stream' }); res.end(await readFile(target));
   } catch (error) { res.writeHead(500); res.end(error.message); }
  });
  await new Promise(resolve => server.listen(8091 + index, '127.0.0.1', resolve)); servers.push(server);
 }
 return () => Promise.all(servers.map(server => new Promise(resolve => server.close(resolve))));
}
if (process.argv[1] === fileURLToPath(import.meta.url)) { await startServers(); console.log('Önizleme: http://127.0.0.1:8091 / 8092 / 8093 / 8094'); }
