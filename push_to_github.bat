@echo off
echo.
echo ==================================================
echo   INVENTARIO TI - MANDANDO O PROJETO PRO GITHUB!
echo ==================================================
echo.
echo Preparando seus arquivos para envio...
git add .
git commit -m "Feat: Sistema de Login com permissoes, UI Design Premium Guna2, CRUD completo e Roteiro"

echo.
echo Conectando com a sua pagina: https://github.com/Gustavo-vv/InventarioTIe.git ...
git remote remove origin 2>nul
git remote add origin https://github.com/Gustavo-vv/InventarioTIe.git

echo.
echo Renomeando branch principal para main...
git branch -M main

echo.
echo ==================================================
echo.
echo Enviando 100%% do projeto para a nuvem do GitHub...
git push -u origin main

echo.
echo ==================================================
echo SE TUDO DEU CERTO (Não apareceu "Erro" vermelho em cima):
echo O sistema foi hospedado com SUCESSO na nuvem! Aperte F5 no site do Github!
echo ==================================================
pause
