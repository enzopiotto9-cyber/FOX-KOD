# TODO — Remover “Conta (Privacidade)” do site

- [ ] Remover UI de login/criação/saída e toda lógica `bb_account` e `bb_users_v1` do `blackbox-dashboard-app/index.html`.
- [ ] Ajustar páginas que ainda usam `bb_account` para não dependerem de conta:
  - [ ] `blackbox-dashboard-app/_pages/notas.html`
  - [ ] `blackbox-dashboard-app/_pages/timer.html`
  - [ ] `blackbox-dashboard-app/_pages/calculadora.html`
  - [ ] `blackbox-dashboard-app/_pages/chatbot.html`
  - [ ] `blackbox-dashboard-app/_pages/painel.html` (se existir/estiver referenciado)
- [ ] Em cada página acima, trocar namespace `bb_*_${getAccount()}` / `bb_account` por chaves fixas (ex.: `bb_notes__...`, `bb_timer__...`, etc.).
- [ ] Remover da `tarefas.html` o bloco restante que ainda lê `bb_account` / `getAccount()` e deixar apenas `bb_kanban__...`.
- [ ] Rodar uma checagem rápida no projeto buscando `bb_account` e garantir que não reste no site.
- [ ] Opcional: orientar reset de dados locais do navegador para limpar chaves antigas.

