<script setup lang="ts">
defineProps<{ fahrenheit: number, celsius: number }>();
</script>

<template>
    <div>
        <p class="text-gray-600">Low: {{ fahrenheit }}°F / {{ celsius }}°C</p>
    </div>
</template>