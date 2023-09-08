<script setup lang="ts">
defineProps<{ fahrenheit: number, celsius: number }>();
</script>

<template>
    <div>
        <p class="text-gray-700 font-semibold">High: {{ fahrenheit }}°F / {{ celsius }}°C</p>
    </div>
</template>